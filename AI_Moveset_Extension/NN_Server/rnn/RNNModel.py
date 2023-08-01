import tensorflow as tf
import numpy as np

def train(loss_val, var_list, lr, max_grad=1):
    optimizer = tf.train.AdamOptimizer(lr, beta1=0.9)
    grads, _ = tf.clip_by_global_norm(tf.gradients(loss_val, var_list), max_grad)
    return optimizer.apply_gradients(zip(grads, var_list))


class RNNConfig(object):

    RNN_SIZE = 512
    NUM_OF_LAYERS = 4
    
    forget_bias = 0.8
    
    
    X_DIMENSION = 8
    Y_DIMENSION = 196


    def __init__(self):
        pass
    
    def model(self, batchSize, stepSize, lr=0.0001):
        return RNNModel(self, batchSize, stepSize, lr)
    
    def rnn_cell(self):
        size = self.RNN_SIZE
        cell = tf.contrib.rnn.BasicLSTMCell(size, forget_bias=self.forget_bias, state_is_tuple=False)
        return cell
    
        
    def drop_out(self, input_data, keep_prob):
        if (keep_prob == 1):
            return input_data
        else:
            return tf.nn.dropout(input_data, keep_prob)




class RNNModel(object):
    def __init__(self, config, batchSize, stepSize, lr=0.0001):
        self.config = config
        self.batchSize = batchSize
        self.stepSize = stepSize
        config.stepSize = stepSize
        config.batchSize = batchSize
        
        g_input = None
        
        self.x = tf.placeholder(tf.float32, [batchSize, stepSize, config.X_DIMENSION], name="input_x") # input_x is [1, 1, 8]
        
        g_input = self.x
        
        self.prev_y = tf.placeholder(tf.float32, [batchSize, config.Y_DIMENSION], name="prev_y") # prev_y is [1, 196]

        self.prev_state = tf.placeholder(tf.float32, [batchSize, config.RNN_SIZE*config.NUM_OF_LAYERS*2], name="prev_state") # prev_state = [1, 4096]
        
        self.y = tf.placeholder(tf.float32, [batchSize, stepSize, config.Y_DIMENSION], name="y") # y = [1, 1, 196]

        
        with tf.variable_scope("generator"):
            self.generated, self.final_state, self.final_y = self.generator(g_input, self.prev_y, self.prev_state)

            
            
                
            
    def generator(self, inputs, prev_motion, prev_state):
        c = self.config
        cells = []

        for i in range(c.NUM_OF_LAYERS):
            cell = c.rnn_cell()
            cells.append(cell)
                                                     
        stacked_lstm = tf.contrib.rnn.MultiRNNCell(cells, state_is_tuple=False)

        state = tf.reshape(prev_state, [self.batchSize, c.NUM_OF_LAYERS * 2 * c.RNN_SIZE]) # [1, 4096]

        hiddens = []
        output_w = tf.get_variable("output_w", [c.RNN_SIZE, c.Y_DIMENSION], dtype=tf.float32) # [512, 196]
        output_b = tf.get_variable("output_b", [c.Y_DIMENSION], dtype=tf.float32) # [196]


        output = prev_motion # previous y
                    
        cInput = tf.concat([c.drop_out(inputs[:,0,:], 1), output], 1)
        # print("\n\n\n\n", c.drop_out(inputs[:,0,:], 1),"\n\n\n\n")

        
        output, state = stacked_lstm(cInput, state)
        output = tf.matmul(output, output_w) + output_b

        hiddens.append(output)
            
        
        outputs = tf.transpose(hiddens, perm=[1, 0, 2])

        final_state = tf.reshape(state, [self.batchSize, c.NUM_OF_LAYERS * 2 * c.RNN_SIZE])

        return outputs, final_state, output
    

